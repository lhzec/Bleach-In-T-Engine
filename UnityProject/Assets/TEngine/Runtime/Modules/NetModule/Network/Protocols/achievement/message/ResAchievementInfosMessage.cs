using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 全部成就信息 message
 */
public class ResAchievementInfosMessage : Message 
{
	//成就信息
	List<AchievementInfo> _achieveInfo = new List<AchievementInfo>();
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//成就信息
		SerializeUtils.WriteShort(stream, (short)_achieveInfo.Count);

		foreach (var element in _achieveInfo)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//成就信息
		int _achieveInfo_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _achieveInfo_length; ++i) 
		{
			_achieveInfo.Add(SerializeUtils.ReadBean<AchievementInfo>(stream));
		}
	}
	
	/**
	 * get 成就信息
	 * @return 
	 */
	public List<AchievementInfo> GetAchieveInfo()
	{
		return _achieveInfo;
	}
	
	/**
	 * set 成就信息
	 */
	public void SetAchieveInfo(List<AchievementInfo> achieveInfo)
	{
		_achieveInfo = achieveInfo;
	}
	
	
	public override int GetId() 
	{
		return 210300;
	}
}