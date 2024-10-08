using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 灵力修炼最高纪录排名信息列表[初始化] message
 */
public class ResAdvanceTrialRankInfosMessage : Message 
{
	//灵力修炼最高纪录排名信息
	List<AdvanceTrialRankInfo> _rankInfos = new List<AdvanceTrialRankInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//灵力修炼最高纪录排名信息
		SerializeUtils.WriteShort(stream, (short)_rankInfos.Count);

		foreach (var element in _rankInfos)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//灵力修炼最高纪录排名信息
		int _rankInfos_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _rankInfos_length; ++i) 
		{
			_rankInfos.Add(SerializeUtils.ReadBean<AdvanceTrialRankInfo>(stream));
		}
	}
	
	/**
	 * get 灵力修炼最高纪录排名信息
	 * @return 
	 */
	public List<AdvanceTrialRankInfo> GetRankInfos()
	{
		return _rankInfos;
	}
	
	/**
	 * set 灵力修炼最高纪录排名信息
	 */
	public void SetRankInfos(List<AdvanceTrialRankInfo> rankInfos)
	{
		_rankInfos = rankInfos;
	}
	
	
	public override int GetId() 
	{
		return 224107;
	}
}