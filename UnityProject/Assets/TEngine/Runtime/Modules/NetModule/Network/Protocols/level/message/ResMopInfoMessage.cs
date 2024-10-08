using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 返回扫荡结果信息 message
 */
public class ResMopInfoMessage : Message 
{
	//扫荡结果消息Id(0：成功,非0：失败的消息Id)
	int _msg;	
	//扫荡奖励
	List<LevelRewardInfo> _levelRewardInfos = new List<LevelRewardInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//扫荡结果消息Id(0：成功,非0：失败的消息Id)
		SerializeUtils.WriteInt(stream, _msg);
		//扫荡奖励
		SerializeUtils.WriteShort(stream, (short)_levelRewardInfos.Count);

		foreach (var element in _levelRewardInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//扫荡结果消息Id(0：成功,非0：失败的消息Id)
		_msg = SerializeUtils.ReadInt(stream);
		//扫荡奖励
		int _levelRewardInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _levelRewardInfos_length; ++i) 
		{
			_levelRewardInfos.Add(SerializeUtils.ReadBean<LevelRewardInfo>(stream));
		}
	}
	
	/**
	 * 扫荡结果消息Id(0：成功,非0：失败的消息Id)
	 */
	public int Msg
	{
		set { _msg = value; }
	    get { return _msg; }
	}
	
	/**
	 * get 扫荡奖励
	 * @return 
	 */
	public List<LevelRewardInfo> GetLevelRewardInfos()
	{
		return _levelRewardInfos;
	}
	
	/**
	 * set 扫荡奖励
	 */
	public void SetLevelRewardInfos(List<LevelRewardInfo> levelRewardInfos)
	{
		_levelRewardInfos = levelRewardInfos;
	}
	
	
	public override int GetId() 
	{
		return 102102;
	}
}