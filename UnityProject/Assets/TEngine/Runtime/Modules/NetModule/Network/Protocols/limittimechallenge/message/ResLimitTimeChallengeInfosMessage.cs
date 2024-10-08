using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 全部限时挑战信息消息 message
 */
public class ResLimitTimeChallengeInfosMessage : Message 
{
	//全部限时挑战信息实例
	List<LimitTimeChallengeInfoIns> _limitTimeChallengeInfoIns = new List<LimitTimeChallengeInfoIns>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//全部限时挑战信息实例
		SerializeUtils.WriteShort(stream, (short)_limitTimeChallengeInfoIns.Count);

		foreach (var element in _limitTimeChallengeInfoIns)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//全部限时挑战信息实例
		int _limitTimeChallengeInfoIns_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _limitTimeChallengeInfoIns_length; ++i) 
		{
			_limitTimeChallengeInfoIns.Add(SerializeUtils.ReadBean<LimitTimeChallengeInfoIns>(stream));
		}
	}
	
	/**
	 * get 全部限时挑战信息实例
	 * @return 
	 */
	public List<LimitTimeChallengeInfoIns> GetLimitTimeChallengeInfoIns()
	{
		return _limitTimeChallengeInfoIns;
	}
	
	/**
	 * set 全部限时挑战信息实例
	 */
	public void SetLimitTimeChallengeInfoIns(List<LimitTimeChallengeInfoIns> limitTimeChallengeInfoIns)
	{
		_limitTimeChallengeInfoIns = limitTimeChallengeInfoIns;
	}
	
	
	public override int GetId() 
	{
		return 314103;
	}
}